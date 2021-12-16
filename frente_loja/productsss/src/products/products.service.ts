import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Product } from 'src/products/entities/product.entity';
import { Repository } from 'typeorm';
import { CreateProductDto } from './dto/create-product.dto';
import { UpdateProductDto } from './dto/update-product.dto';

@Injectable()
export class ProductsService {
  constructor(
    @InjectRepository(Product)
    private productRepository: Repository<Product>,
  ) { }
  async create(createProductDto: CreateProductDto) {
    const product = this.productRepository.create(createProductDto)
    await this.productRepository.save(createProductDto)
    return product;
  }

  async findAll() {
    return await this.productRepository.find();
  }

  async findOne(id: number): Promise<UpdateProductDto> {
    return await this.productRepository.findOneOrFail({ where: { id: id } });
  }

  async update(id: number, updateProductDto: UpdateProductDto) {
    await this.productRepository.update(id, updateProductDto)
    return await this.productRepository.findOne({ id })
  }

  async remove(id: number) {
    await this.productRepository.delete({ id: id });
    return { deleted: true }
  }
}
