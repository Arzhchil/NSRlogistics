import { Component } from '@angular/core';
import { FileUploadService } from '../../services';

@Component({
  selector: 'app-dropzone',
  templateUrl: './dropzone.component.html',
  styleUrls: ['./dropzone.component.scss'],
})
export class DropzoneComponent {
  isDragging = false;
  file: File | null = null;

  constructor(private fileUploadService: FileUploadService) {}

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
        console.log(this.file); //Затычка, потом убрать
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
        console.log(this.file); //Затычка, потом убрать
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
      next: (response) => console.log('Файл успешно загружен', response),
      error: (error) => console.error('Ошибка загрузки файла', error),
    });
  }
}
