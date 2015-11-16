import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 26/10/2015.
 */
public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().toLowerCase().split("\\W+");

        List<String> result = new ArrayList<>();

        for (int i = 0; i < line.length; i++) {
            boolean test=false;
            for (int j = i+1; j < line.length; j++) {
                if (line[i].contains(line[j])){
                    test=true;
                }
            }
            if (test==false){
                result.add(line[i]);
            }
        }
        Collections.sort(result);

        for (int i = 0; i < result.size(); i++) {
            System.out.print(result.get(i)+" ");
        }
    }
}
