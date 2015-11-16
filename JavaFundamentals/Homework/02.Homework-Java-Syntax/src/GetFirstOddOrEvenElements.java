
import java.util.ArrayList;

import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 17/10/2015.
 */
public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");
        String[] comand = Console.nextLine().split(" ");
        int comandCount = Integer.parseInt(comand[1]);
        int[] numberLine = new int[line.length];

        for (int i = 0; i < numberLine.length; i++) {
            numberLine[i] = Integer.parseInt(line[i]);
        }


        List<Integer> oddList = new ArrayList<Integer>();
        List<Integer> evenList = new ArrayList<Integer>();


        for (int i = 0; i < numberLine.length; i++) {
            if (numberLine[i] % 2 == 1) {
                oddList.add(numberLine[i]);
            } else if (numberLine[i] % 2 == 0) {
                evenList.add(numberLine[i]);
            }
        }

        FirstOddOrEven(oddList, evenList, comandCount, comand);

    }

    private static void FirstOddOrEven(List<Integer> oddList, List<Integer> evenList, int comandCount, String[] comand) {

        if (comand[2].equals("odd")) {
            for (int i = 0; i < comandCount; i++) {
                System.out.printf("%d ", oddList.get(i));
            }
        } else if (comand[2].equals("even")) {
            for (int i = 0; i < comandCount; i++) {
                System.out.printf(evenList.get(i) + " ");
            }
        }
    }
}
