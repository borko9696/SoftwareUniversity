import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 13/11/2015.
 */
public class ClearingCommand {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<String[]> list = new ArrayList<>();
        List<String[]> clone = new ArrayList<>();
        String input = sc.nextLine();
        while (!input.equals("END")) {
            list.add(input.split(""));
            input = sc.nextLine();
        }

        for (int i = 0; i < list.size(); i++) {
            String[] arr = new String[list.get(i).length];
            for (int j = 0; j < list.get(i).length; j++) {
                arr[j] = list.get(i)[j];
            }
            clone.add(arr);
        }


        for (int i = 0; i < list.size(); i++) {
            for (int j = 0; j < list.get(i).length; j++) {
                if (list.get(i)[j].equals(">")) {
                    clone.get(i)[j] = "&gt;";
                    for (int k = j+1; k < list.get(i).length; k++) {
                        if (list.get(i)[k].equals(">")||
                                list.get(i)[k].equals("<")||
                                list.get(i)[k].equals("^")||
                                list.get(i)[k].equals("v")) {
                            break;
                        }else {
                            clone.get(i)[k]=" ";
                        }
                    }
                } else if (list.get(i)[j].equals("<")) {
                    clone.get(i)[j] = "&lt;";
                    for (int k =j-1 ; k >= 0; k--) {
                        if (list.get(i)[k].equals(">")||
                                list.get(i)[k].equals("<")||
                                list.get(i)[k].equals("^")||
                                list.get(i)[k].equals("v")) {
                            break;
                        }else {
                            clone.get(i)[k]=" ";
                        }
                    }

                } else if (list.get(i)[j].equals("^")) {
                    for (int k = i-1; k >= 0; k--) {
                        if (list.get(k)[j].equals(">")||
                                list.get(k)[j].equals("<")||
                                list.get(k)[j].equals("^")||
                                list.get(k)[j].equals("v")) {
                            break;
                        }else {
                            clone.get(k)[j]=" ";
                        }
                    }

                } else if (list.get(i)[j].equals("v")) {
                    for (int k = i+1; k < list.size(); k++) {
                        if (list.get(k)[j].equals(">")||
                                list.get(k)[j].equals("<")||
                                list.get(k)[j].equals("^")||
                                list.get(k)[j].equals("v")) {
                            break;
                        }else {
                            clone.get(k)[j]=" ";
                        }
                    }
                }
            }
        }
        for (int i = 0; i < clone.size(); i++) {
            System.out.print("<p>");
            for (int j = 0; j < clone.get(i).length; j++) {
                System.out.print(clone.get(i)[j] + "");
            }
            System.out.println("</p>");
        }
    }
}
