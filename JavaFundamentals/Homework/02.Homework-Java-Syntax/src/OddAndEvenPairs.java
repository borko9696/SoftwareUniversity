import java.util.Scanner;

/**
 * Created by Borislav on 16/10/2015.
 */
public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");

        if (line.length%2==1){
            System.out.println("Invalid length");
        }
        else{
            for (int i = 0; i < line.length-1; i+=2) {
                if (Integer.parseInt(line[i])%2==0 && Integer.parseInt(line[i+1])%2==0){
                    System.out.printf("%1$d, %2$d -> both are even \n",Integer.parseInt(line[i]),Integer.parseInt(line[i+1]));
                }
                else if (Integer.parseInt(line[i])%2==1 && Integer.parseInt(line[i+1])%2==1){
                    System.out.printf("%1$d, %2$d -> both are odd \n",Integer.parseInt(line[i]),Integer.parseInt(line[i+1]));
                }
                else{
                    System.out.printf("%1$d, %2$d -> different \n",Integer.parseInt(line[i]),Integer.parseInt(line[i+1]));
                }
            }
        }

    }
}
