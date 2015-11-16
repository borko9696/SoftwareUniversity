import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 16/11/2015.
 */
public class SoftUniPalatkaConf {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int countPeople = Integer.parseInt(sc.nextLine());
        int n = Integer.parseInt(sc.nextLine());
        List<String> list = new ArrayList<>();
        int food = 0;
        int beds = 0;

        for (int i = 0; i < n; i++) {
            String line = sc.nextLine();
            list.add(line);
        }
        for (int i = 0; i < list.size(); i++) {
            String[] splitComand = list.get(i).split(" ");
            String foodOrRoom = splitComand[0];
            int count = Integer.parseInt(splitComand[1]);
            String type = splitComand[2];
            if (foodOrRoom.equals("tents")) {
                if (type.equals("normal")) {
                    beds += (count * 2);
                } else if (type.equals("firstClass")) {
                    beds += (count * 3);
                }
            } else if (foodOrRoom.equals("food")) {
                if (type.equals("musaka")) {
                    food += (count * 2);
                } else if (type.equals("zakuska")) {
                    food += 0;
                }
            } else if (foodOrRoom.equals("rooms")) {
                if (type.equals("single")) {
                    beds += (count * 1);
                } else if (type.equals("double")) {
                    beds += (count * 2);
                } else if (type.equals("triple")) {
                    beds += (count * 3);
                }
            }
        }

        int bedsNeeded = beds - countPeople;
        int foodNeeded = food - countPeople;

        if (bedsNeeded < 0) {
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", Math.abs(bedsNeeded));
        } else {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", bedsNeeded);
        }

        if (foodNeeded < 0) {
            System.out.printf("People are starving. Meals needed: %d\n", Math.abs(foodNeeded));
        } else {
            System.out.printf("Nobody left hungry. Meals left: %d\n", foodNeeded);
        }


    }
}

