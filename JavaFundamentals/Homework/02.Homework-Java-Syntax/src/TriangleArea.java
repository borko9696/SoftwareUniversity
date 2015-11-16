import java.util.Scanner;

/**
 * Created by Borislav on 14/10/2015.
 */
public class TriangleArea {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);

        String[] firstPoint=Console.nextLine().split(" ");
        int firstX=Integer.parseInt(firstPoint[0]);
        int firstY=Integer.parseInt(firstPoint[1]);

        String[] secondPoint=Console.nextLine().split(" ");
        int secondX=Integer.parseInt(secondPoint[0]);
        int secondY=Integer.parseInt(secondPoint[1]);

        String[] thirdPoint=Console.nextLine().split(" ");
        int thirdX=Integer.parseInt(thirdPoint[0]);
        int thirdY=Integer.parseInt(thirdPoint[1]);

        int formul=Math.abs((firstX * (secondY - thirdY) + secondX *
                (thirdY - firstY) + thirdX *
                (firstY - secondY))/2);

        System.out.println(formul);
    }
}
