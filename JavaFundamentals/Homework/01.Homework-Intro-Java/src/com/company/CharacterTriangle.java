package com.company;

import java.util.Scanner;

/**
 * Created by Borislav on 13/10/2015.
 */
public class CharacterTriangle {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        
        for (int i = 1; i <= n ; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print((char)(97 + j) + " " );
            }
            System.out.println();
        }
        for (int i = 0; i < n-1; i++) {
            for (int j = n-1; j > i; j--) {
                System.out.print((char)(96 + n - j) + " "  );
            }
            System.out.println();
        }

    }
}
