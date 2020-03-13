import { TestBed } from '@angular/core/testing';

import { CategoriaSubCategoriaService } from './categoria-sub-categoria.service';

describe('CategoriaSubCategoriaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CategoriaSubCategoriaService = TestBed.get(CategoriaSubCategoriaService);
    expect(service).toBeTruthy();
  });
});
