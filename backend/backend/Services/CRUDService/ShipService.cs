using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Services.CRUDService
{
    public class ShipService : BaseService, ICRUD<ShipCrudDTO>
    {
        public ShipService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// добавление нового судна
        /// </summary>
        /// <param name="shipDTO"></param>
        /// <exception cref="Exception"></exception>
        public async Task<ActionResult<bool>> Add(ShipCrudDTO shipDTO)
        {
            ShipClass? shipClass = await context.ShipClass.FirstOrDefaultAsync(x => x.Id == shipDTO.ShipClassId);

            if (shipClass == null)
            {
                throw new Exception("Не удалось найти судно по указанному идентификатору.");
            }

            Ship ship = new Ship()
            {
                ShipClass = shipClass,
                ShipClassId = shipDTO.ShipClassId,
                ShipName = shipDTO.ShipName,
                Speed = shipDTO.Speed,
            };

            context.Add(ship);
            await context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// изменение существующего судна
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newData"></param>
        /// <exception cref="Exception"></exception>
        public async Task<ActionResult<bool>> Change(Guid id, ShipCrudDTO newData)
        {
            Ship? ship = await context.Ship.FindAsync(id);
            if (ship == null)
            {
                throw new Exception("Не удалось найти судно по указанному идентификатору.");
            }
            if (ship.ShipClassId != newData.ShipClassId)
            {
                throw new Exception("Изменение невозможно, указан неверный класс корабля");
            }

            //подменяем данные о пренадлежности на всякий случай(если нашли корабль)
            newData.ShipClassId = ship.ShipClassId;

            mapper.Map(newData, ship);
            await context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Удаление корабля из базы
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            Ship? ship = await context.Ship.FirstOrDefaultAsync(x => x.Id == id);

            if (ship == null)
            {
                throw new Exception("Не удалось найти судно по указанному идентификатору.");
            }

            context.Remove(ship);
            await context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Получение одного корабля
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ShipCrudDTO> Get(Guid id)
        {
            Ship? ship = await context.Ship.Where(x => x.Id == id).Include(x => x.ShipClass).FirstOrDefaultAsync();

            if (ship == null)
            {
                throw new Exception("Не удалось найти судно по указанному идентификатору.");
            }

            ShipCrudDTO shipDTO = mapper.Map(ship, new ShipCrudDTO());

            return shipDTO;
        }

        /// <summary>
        /// Получение списка всех кораблей
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ICollection<ShipCrudDTO>> GetList()
        {
            List<Ship> lShip = await context.Ship.ToListAsync();

            List<ShipCrudDTO> lShipDTO = mapper.Map(lShip, new List<ShipCrudDTO>());

            return lShipDTO;
        }
    }
}
