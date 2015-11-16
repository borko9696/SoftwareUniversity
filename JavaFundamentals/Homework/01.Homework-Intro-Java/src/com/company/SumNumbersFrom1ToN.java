package com.company;

import java.util.Scanner;

/**
 * Created by Borislav on 13/10/2015.
 */
public class SumNumbersFrom1ToN {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int sum = 0;
        for (int i = 0; i <= n; i++) {
            sum += i;
        }
        System.out.println(sum);
    }
}
