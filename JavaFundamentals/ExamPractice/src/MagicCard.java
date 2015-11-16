import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 20/10/2015.
 */
public class MagicCard {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] input = Console.nextLine().split(" ");
        String oddOrEven = Console.nextLine();
        String magicCard = Console.nextLine();

        List<String> oddCards = new ArrayList<>();
        List<String> evenCards = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            if (i % 2 == 0) {
                evenCards.add(input[i]);
            } else {
                oddCards.add(input[i]);
            }
        }
        int sum = 0;
        if (oddOrEven.equals("even")) {
            for (int i = 0; i < evenCards.size(); i++) {
                switch (evenCards.get(i).charAt(0)) {
                    case '2':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 60;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 40;
                        } else {
                            sum += 20;
                        }
                        break;
                    case '3':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 90;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 60;
                        } else {
                            sum += 30;
                        }
                        break;
                    case '4':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 120;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 80;
                        } else {
                            sum += 40;
                        }
                        break;
                    case '5':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 150;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 100;
                        } else {
                            sum += 50;
                        }
                        break;
                    case '6':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 180;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 120;
                        } else {
                            sum += 60;
                        }
                        break;
                    case '7':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 210;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 140;
                        } else {
                            sum += 70;
                        }
                        break;
                    case '8':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 240;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 160;
                        } else {
                            sum += 80;
                        }
                        break;
                    case '9':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 270;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 180;
                        } else {
                            sum += 90;
                        }
                        break;
                    case '1':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 300;
                        } else if (evenCards.get(i).charAt(2) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 200;
                        } else {
                            sum += 100;
                        }
                        break;
                    case 'J':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 360;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 240;
                        } else {
                            sum += 120;
                        }
                        break;
                    case 'Q':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 390;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 260;
                        } else {
                            sum += 130;
                        }
                        break;
                    case 'K':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 420;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 280;
                        } else {
                            sum += 140;
                        }
                        break;
                    case 'A':
                        if (evenCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 450;
                        } else if (evenCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 300;
                        } else {
                            sum += 150;
                        }
                        break;

                }
            }
        } else if (oddOrEven.equals("odd")) {
            for (int i = 0; i < oddCards.size(); i++) {
                switch (oddCards.get(i).charAt(0)) {
                    case '2':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 60;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 40;
                        } else {
                            sum += 20;
                        }
                        break;
                    case '3':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 90;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 60;
                        } else {
                            sum += 30;
                        }
                        break;
                    case '4':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 120;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 80;
                        } else {
                            sum += 40;
                        }
                        break;
                    case '5':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 150;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 100;
                        } else {
                            sum += 50;
                        }
                        break;
                    case '6':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 180;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 120;
                        } else {
                            sum += 60;
                        }
                        break;
                    case '7':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 210;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 140;
                        } else {
                            sum += 70;
                        }
                        break;
                    case '8':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 240;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 160;
                        } else {
                            sum += 80;
                        }
                        break;
                    case '9':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 270;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 180;
                        } else {
                            sum += 90;
                        }
                        break;
                    case '1':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 300;
                        } else if (oddCards.get(i).charAt(2) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 200;
                        } else {
                            sum += 100;
                        }
                        break;
                    case 'J':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 360;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 240;
                        } else {
                            sum += 120;
                        }
                        break;
                    case 'Q':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 390;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 260;
                        } else {
                            sum += 130;
                        }
                        break;
                    case 'K':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 420;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 280;
                        } else {
                            sum += 140;
                        }
                        break;
                    case 'A':
                        if (oddCards.get(i).charAt(0) == magicCard.charAt(0)) {
                            sum += 450;
                        } else if (oddCards.get(i).charAt(1) == magicCard.charAt(magicCard.length()-1)) {
                            sum += 300;
                        } else {
                            sum += 150;
                        }
                        break;
                }
            }
        }
        System.out.println(sum);
    }
}
