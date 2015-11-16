import jdk.nashorn.internal.runtime.regexp.joni.Regex;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 31/10/2015.
 */
public class WeirdScript {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int n = Integer.parseInt(Console.nextLine());

        StringBuilder input = new StringBuilder();
        String line = Console.nextLine();
        while (!line.equals("End")){
            input.append(line);
            line = Console.nextLine();
        }

        String inputLine = input.toString();


        int size = n / 26;
        int let = n % 26;
        String letter = Character.toString((char)(96+let));
        StringBuilder readyLetter = new StringBuilder();


        if ((n % 26 == 0)) {
            if (size%2==0) {
               readyLetter.append("ZZ");
            }else{
                readyLetter.append("zz");
            }
            String rdyLetter = readyLetter.toString();
            Pattern pat = Pattern.compile(rdyLetter + "(.*?)" + rdyLetter);
            Matcher match = pat.matcher(inputLine);
            while (match.find()){
                System.out.println(match.group(1));
            }


        } else {

            if (size%2==1) {
                 readyLetter.append(letter.toUpperCase());
                 readyLetter.append(letter.toUpperCase());
            }else{
                readyLetter.append(letter);
                readyLetter.append(letter);
            }
            String rdyLetter = readyLetter.toString();

            Pattern pat = Pattern.compile(rdyLetter + "(.*?)" + rdyLetter);
            Matcher match = pat.matcher(inputLine);
            while (match.find()){
                System.out.println(match.group(1));
            }
        }

    }
}
