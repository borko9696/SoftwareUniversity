package com.company;

import java.util.Scanner;

/**
 * Created by Borislav on 13/10/2015.
 */
public class GetAverage {
    public static void main(String[] args){
        Scanner input=new Scanner(System.in);
        float a= input.nextFloat();
        float b= input.nextFloat();
        float c= input.nextFloat();
        float sum=a+b+c;
        float result=sum/3;
        System.out.printf("%.2f",result);
    }
}
