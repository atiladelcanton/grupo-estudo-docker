import { Entity, Column, PrimaryGeneratedColumn } from 'typeorm';
@Entity({ name: "products" })
export class Product {
    @PrimaryGeneratedColumn()
    id: number;

    @Column()
    name: string;

    @Column()
    price: number;

    @Column()
    stock: number;

    @Column({ default: true })
    isActive: boolean;

}
