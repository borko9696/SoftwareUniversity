import java.util.Scanner;

/**
 * Created by Borislav on 16/10/2015.
 */
public class CharacterMultiplier {
    public static void main(String[] args) {

        Scanner Console=new Scanner(System.in);
        String[] input = Console.nextLine().split(" ");
        String str1=input[0];
        String str2=input[1];

        System.out.println(SumOfElements(str1, str2));


    }
    private static int SumOfElements(String str1,String str2){
        int sum=0;
        if (str1.length()==str2.length()){
            for (int i = 0; i < str1.length(); i++) {
                sum+=(str1.charAt(i)*str2.charAt(i));
            }
        }
        else {
            if (str1.length() > str2.length()) {

                for (int i = 0; i < str2.length(); i++) {
                    sum += str1.charAt(i) * str2.charAt(i);
                }
                for (int j = str2.length(); j < str1.length(); j++) {
                    sum += str1.charAt(j);
                }

            } else {
                for (int i = 0; i < str1.length(); i++) {
                    sum += str1.charAt(i) * str2.charAt(i);
                }
                for (int j = str1.length(); j < str2.length(); j++) {
                    sum += str2.charAt(j);
                }

            }
        }
        return sum;
    }
}
