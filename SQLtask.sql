Select  Product.product_name as product, 
		Category.category_name as category
from Product 
	Left Join StoreCatalog on Product.product_id = StoreCatalog.product_id 
	Left Join Category on StoreCatalog.category_id = Category.category_id