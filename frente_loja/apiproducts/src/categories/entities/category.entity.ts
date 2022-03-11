import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm';
@Entity({ name: 'categories' })
export class Category {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  name: string;

  @Column()
  created_at: Date;

  @Column()
  updated_at: Date;
}
