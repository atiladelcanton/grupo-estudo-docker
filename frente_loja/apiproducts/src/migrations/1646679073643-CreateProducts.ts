import { MigrationInterface, QueryRunner, Table, TableForeignKey } from "typeorm";

export class CreateProducts1646679073643 implements MigrationInterface {

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.createTable(
            new Table({
                name: 'products',
                columns: [
                    {
                        name: 'id',
                        type: 'integer',
                        isPrimary: true,
                        isGenerated: true,
                        generationStrategy: 'increment',
                    },
                    {
                        name: 'category_id',
                        type: 'integer',
                    },
                    {
                        name: 'name',
                        type: 'varchar(200)',
                    },
                    {
                        name: 'price',
                        type: 'int',
                    },
                    {
                        name: 'stock',
                        type: 'int',
                    },
                    {
                        name: 'active',
                        type: 'boolean',
                    },
                    {
                        name: 'created_at',
                        type: 'timestamp',
                        default: 'now()',
                    },
                    {
                        name: 'updated_at',
                        type: 'timestamp',
                        default: 'now()',
                    },
                ]
            }));
        await queryRunner.createForeignKey(
            'products',
            new TableForeignKey({
                columnNames: ['category_id'],
                referencedTableName: 'categories',
                referencedColumnNames: ['id']
            })
        );
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
    }

}
