import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 21/10/2015.
 */
public class LabyrinthDash {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int n = Integer.parseInt(Console.nextLine());
        List<char[]> map = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String line = Console.nextLine();
            map.add(line.toCharArray());
        }
        int positionCol = 0;
        int positionRow = 0;
        int lives = 3;
        int moves = 0;
        String command = Console.nextLine();

        try {
            for (int i = 0; i < command.length(); i++) {
                if (lives == 0) {
                    break;
                }

                switch (command.charAt(i)) {
                    case '>':
                        switch (map.get(positionRow)[positionCol + 1]) {
                            case '_':
                            case '|':
                                System.out.println("Bumped a wall.");
                                break;
                            case '@':
                            case '#':
                            case '*':
                                lives--;
                                moves++;
                                positionCol++;
                                if (lives == 0) {
                                    System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                    System.out.println("No lives left! Game Over!");
                                    break;
                                }
                                System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                break;
                            case '$':
                                lives++;
                                map.get(positionRow)[positionCol + 1]='.';
                                positionCol++;
                                moves++;
                                System.out.printf("Awesome! Lives left: %d\n", lives);
                                break;
                            case '.':
                                positionCol++;
                                moves++;
                                System.out.println("Made a move!");
                                break;
                            case ' ':
                                positionCol++;
                                lives = 0;
                                moves++;
                                System.out.println("Fell off a cliff! Game Over!");
                                break;

                        }
                        break;


                    case '<':
                        switch (map.get(positionRow)[positionCol - 1]) {
                            case '_':
                            case '|':
                                System.out.println("Bumped a wall.");
                                break;
                            case '@':
                            case '#':
                            case '*':
                                lives--;
                                moves++;
                                positionCol--;
                                if (lives == 0) {
                                    System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                    System.out.println("No lives left! Game Over!");
                                    break;
                                }
                                System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                break;
                            case '$':
                                lives++;
                                map.get(positionRow)[positionCol-1]='.';
                                positionCol--;
                                moves++;
                                System.out.printf("Awesome! Lives left: %d\n", lives);
                                break;
                            case '.':
                                positionCol--;
                                moves++;
                                System.out.println("Made a move!");
                                break;
                            case ' ':
                                positionCol--;
                                lives = 0;
                                moves++;
                                System.out.println("Fell off a cliff! Game Over!");
                                break;
                        }
                        break;
                    case 'v':
                        switch (map.get(positionRow + 1)[positionCol]) {
                            case '_':
                            case '|':
                                System.out.println("Bumped a wall.");
                                break;
                            case '@':
                            case '#':
                            case '*':
                                lives--;
                                moves++;
                                positionRow++;
                                if (lives == 0) {
                                    System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                    System.out.println("No lives left! Game Over!");
                                    break;
                                }
                                    System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                break;
                            case '$':
                                lives++;
                                map.get(positionRow + 1)[positionCol]='.';
                                positionRow++;
                                moves++;
                                System.out.printf("Awesome! Lives left: %d\n", lives);
                                break;
                            case '.':
                                positionRow++;
                                moves++;
                                System.out.println("Made a move!");
                                break;
                            case ' ':
                                positionRow++;
                                lives = 0;
                                moves++;
                                System.out.println("Fell off a cliff! Game Over!");
                                break;
                        }

                        break;
                    case '^':
                        switch (map.get(positionRow - 1)[positionCol]) {
                            case '_':
                            case '|':
                                System.out.println("Bumped a wall.");
                                break;
                            case '@':
                            case '#':
                            case '*':
                                lives--;
                                moves++;
                                positionRow--;
                                if (lives == 0) {
                                    System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                    System.out.println("No lives left! Game Over!");
                                    break;
                                }
                                System.out.printf("Ouch! That hurt! Lives left: %d\n", lives);
                                break;
                            case '$':
                                lives++;
                                map.get(positionRow - 1)[positionCol]='.';
                                positionRow--;
                                moves++;
                                System.out.printf("Awesome! Lives left: %d\n", lives);
                                break;
                            case '.':
                                positionRow--;
                                moves++;
                                System.out.println("Made a move!");
                                break;
                            case ' ':
                                positionRow--;
                                lives = 0;
                                moves++;
                                System.out.println("Fell off a cliff! Game Over!");
                                break;
                        }
                        break;
                }
            }

            System.out.printf("Total moves made: %d", moves);

        } catch (ArrayIndexOutOfBoundsException exception) {
            System.out.println("Fell off a cliff! Game Over!");
            moves++;
            System.out.printf("Total moves made: %d", moves);
        }

    }
}