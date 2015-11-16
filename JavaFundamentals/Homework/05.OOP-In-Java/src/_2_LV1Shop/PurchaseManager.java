package _2_LV1Shop;
import _2_LV1Shop.Customers.Customer;
import _2_LV1Shop.Enum.AgeRestriction;
import _2_LV1Shop.Exceptions.NoPermissionException;
import _2_LV1Shop.Exceptions.ProductExpiredException;
import _2_LV1Shop.Exceptions.NoMoneyException;
import _2_LV1Shop.Exceptions.NoQuantityException;
import _2_LV1Shop.Products.FoodProduct;
import _2_LV1Shop.Products.Product;
import java.util.Date;

public final class PurchaseManager {

    public static void processPurchase(Customer customer, Product product) throws NoPermissionException, NoMoneyException, NoQuantityException, ProductExpiredException {

        if(product.getAgeRestriction() == AgeRestriction.Adult && customer.getAge() < 18){
            throw new NoPermissionException();
        } else if (product.getAgeRestriction() == AgeRestriction.Teenager && customer.getAge() < 14){
            throw new NoPermissionException();
        } else if(customer.getBalance() - product.getPrice() < 0) {
            throw new NoMoneyException();
        } else if (product.getQuantity() < 1) {
            throw new NoQuantityException();
        } else if (product instanceof FoodProduct) {
            FoodProduct productCast = (FoodProduct) product;
            if (productCast.getExpirationDate().getTime() < new Date().getTime()) {
                throw new ProductExpiredException();
            }
        }
        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance() - product.getPrice());
    }
}
