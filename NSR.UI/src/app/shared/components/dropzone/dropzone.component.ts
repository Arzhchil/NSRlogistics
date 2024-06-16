import { Component } from '@angular/core';
import { FileUploadService, PostSearchPathService } from '../../services';
import { SearchPathModel } from '../../models';

@Component({
  selector: 'app-dropzone',
  templateUrl: './dropzone.component.html',
  styleUrls: ['./dropzone.component.scss'],
})
export class DropzoneComponent {
  isDragging = false;
  file: File | null = null;
  fileID!: string;
  searchPathModel: SearchPathModel = new SearchPathModel();

  constructor(
    private fileUploadService: FileUploadService,
    private searchPathService: PostSearchPathService
  ) {}

  onDragOver(event: DragEvent): void {
    event.preventDefault();
    event.stopPropagation();
    this.isDragging = true;
  }

  onDragLeave(event: DragEvent): void {
    event.preventDefault();
    event.stopPropagation();
    this.isDragging = false;
  }

  onDrop(event: DragEvent): void {
    event.preventDefault();
    event.stopPropagation();
    this.isDragging = false;

    if (event.dataTransfer && event.dataTransfer.files.length > 0) {
      const droppedFile = event.dataTransfer.files[0];

      if (this.isValidFile(droppedFile)) {
        this.file = droppedFile;
        this.uploadFile(this.file);
      } else {
        alert('Неверный тип файла. Разрешены только файлы .xlsx');
        console.error('Неверный тип файла. Разрешены только файлы .xlsx');
      }
      event.dataTransfer.clearData();
    }
  }

  onFileSelected(event: Event): void {
    const input = event.target as HTMLInputElement;

    if (input.files && input.files.length > 0) {
      const selectedFile = input.files[0];

      if (this.isValidFile(selectedFile)) {
        this.file = selectedFile;
        this.uploadFile(this.file);
      } else {
        alert('Неверный тип файла. Разрешены только файлы .xlsx');
        console.error('Неверный тип файла. Разрешены только файлы .xlsx');
      }
    }
  }

  private isValidFile(file: File): boolean {
    const allowedExtensions = ['xlsx'];
    const fileExtension = file.name.split('.').pop()?.toLowerCase();
    return allowedExtensions.includes(fileExtension || '');
  }

  private uploadFile(file: File): void {
    this.fileUploadService.uploadFiles(file).subscribe({
      next: (response) => {
        console.log('Файл успешно загружен', response);
        this.fileID = response;
        this.searchPathModel.fileId = this.fileID;
        this.searchPathModel.workBookSheet = 0;
        this.searchPathService.PostSearchFile(this.searchPathModel).subscribe({
          next: (response) => {
            console.log('Ответ', response);
          },
          error: (error) => console.error('Ошибка', error),
        });
        console.log(this.searchPathModel);
      },
      error: (error) => console.error('Ошибка загрузки файла', error),
    });
  }
}
