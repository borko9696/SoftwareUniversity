import java.util.*;

/**
 * Created by Borislav on 16/10/2015.
 */
public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int min = Integer.parseInt(Console.nextLine());
        int max = Integer.parseInt(Console.nextLine());

        List<Integer> result =new ArrayList<>();
        for (int i = min; i <= max ; i++) {
        result.add(i);
        }
        Collections.shuffle(result);
        for (Integer num: result){
            System.out.print(num+ " ");
        }
    }
}
