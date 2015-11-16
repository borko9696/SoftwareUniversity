import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 20/10/2015.
 */
public class Enigma {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int n = Integer.parseInt(Console.nextLine());
        List<char[]> inputList = new ArrayList<>();
        String strlenght = "";

        for (int i = 0; i < n; i++) {
            String line = Console.nextLine();
            inputList.add(line.toCharArray());
            strlenght += line;
        }



        int[] countNumbs=new int[n];
        for (int i = 0; i < inputList.size(); i++) {
            int count=0;
            for (int j = 0; j <inputList.get(i).length ; j++) {
                int chek = (int)inputList.get(i)[j];
                if ((chek < 48 || chek > 57) && chek != 32) {
                count++;
                }
            }
            countNumbs[i]=count;
        }



        List<String> result = new ArrayList<>();

        for (int i = 0; i < inputList.size(); i++) {
            char[] arr = new char[inputList.get(i).length];
            for (int j = 0; j < inputList.get(i).length; j++) {
                int ascii = (int)inputList.get(i)[j];
                if ((ascii < 48 || ascii > 57) && ascii != 32) {
                    int convert = ascii + (countNumbs[i]/2);
                    char readyChar = (char) convert;
                    arr[j]=readyChar;
                }
                else {
                    int convert = ascii;
                    char readyChar = (char) convert;
                    arr[j]=readyChar;
                }
            }
            String value =String.valueOf(arr);
            result.add(value);
        }

        for (int i = 0; i < result.size() ; i++) {

                System.out.println(result.get(i));
        }
    }
}
