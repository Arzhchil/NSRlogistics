import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FileDropzonePageComponent } from './file-dropzone-page.component';

describe('FileDropzonePageComponent', () => {
  let component: FileDropzonePageComponent;
  let fixture: ComponentFixture<FileDropzonePageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FileDropzonePageComponent]
    });
    fixture = TestBed.createComponent(FileDropzonePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
