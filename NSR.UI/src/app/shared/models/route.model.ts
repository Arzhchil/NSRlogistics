import { Point } from './point.interface';

export class RouteModel {
  public id!: string;
  public start!: Point;
  public startId!: string;
  public finish!: Point;
  public finishId!: string;
}
