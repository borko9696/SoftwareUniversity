package _2_LV1Shop.Products;

import _2_LV1Shop.Enum.AgeRestriction;

import java.util.Date;

/**
 * Created by Simooo on 30.10.2015 ã..
 */
public class Appliance extends ElectonicsProduct {

    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = new Date(new Date().getYear() , new Date().getMonth() + 6, new Date().getDate());
    }

    @Override
    public double getPrice() {
        double price = this.price();
        if(this.getQuantity() < 50) {
            price *= 1.05;
        }
        return price;
    }
}
