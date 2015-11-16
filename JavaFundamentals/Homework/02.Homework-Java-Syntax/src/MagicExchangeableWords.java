import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Borislav on 17/10/2015.
 */
public class MagicExchangeableWords {
    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");
        String firstWord = line[0];
        String secondWord = line[1];
        int[] firstNum = new int[firstWord.length()];
        int[] secondNum = new int[secondWord.length()];
        boolean result=true;

        System.out.println(ExchangebleWords(firstWord, secondWord, firstNum, secondNum,result));


    }

    private static boolean ExchangebleWords(String firstWord, String secondWord, int[] firstNum, int[] secondNum, boolean result) {


        for (int i = 0; i < firstWord.length(); i++) {
            for (int j = i + 1; j < firstWord.length(); j++) {
                if (firstWord.charAt(i) == firstWord.charAt(j)) {
                    firstNum[i] = i;
                    firstNum[j] = i;
                    i++;
                } else {
                    firstNum[i] = i;
                }
            }
        }
        for (int i = 0; i < secondWord.length(); i++) {
            for (int j = i + 1; j < secondWord.length(); j++) {
                if (secondWord.charAt(i) == secondWord.charAt(j)) {
                    secondNum[i] = i;
                    secondNum[j] = i;
                    i++;
                } else {
                    secondNum[i] = i;
                }
            }
        }
        String number1 = Arrays.toString(firstNum);
        String number2 = Arrays.toString(secondNum);

        if (number1.equals(number2)) {
           return result;

        } else {
            result=false;
            return result;
        }
    }
}
