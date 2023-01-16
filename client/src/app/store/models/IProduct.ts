export interface IProduct{
  id: number,
  name: string,
  price: number,
  amount: number,
  description: string,
  categoryId: number,
  brandId: number
  images: IImage[]
}
export interface IImage{
  id: number,
  path: string
}
