import java.util.Scanner;

/**
 * Created by Borislav on 13/11/2015.
 */
public class TextGravity {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double col = Double.parseDouble(sc.nextLine());
        String input = sc.nextLine();

        double test = input.length() / col;
        double row = Math.ceil(test);
        StringBuilder sb = new StringBuilder();
        sb.append(input);
        while (sb.length() < (int) row * (int) col) {
            sb.append(" ");
        }
        String resultStr = sb.toString();

        char[][] matrix = new char[(int) row][(int) col];

        int count = 0;
        for (int i = 0; i < (int) row; i++) {
            for (int j = 0; j < (int) col; j++) {
                matrix[i][j] = resultStr.charAt(count);
                count++;
            }
        }
        for (int r = 0; r < (int) row; r++) {

            for (int i = 0; i < (int) row - 1; i++) {
                for (int j = 0; j < (int) col; j++) {
                    if (matrix[(int) i + 1][(int) j] == ' ') {
                        char temp = matrix[i + 1][j];
                        matrix[i + 1][j] = matrix[i][j];
                        matrix[i][j] = temp;
                    }
                }
            }
        }

        for (int row1 = 0; row1 < (int) row; row1++) {
            if (row1 == 0) {
                System.out.printf("<table>");
            }
            System.out.printf("<tr>");
            for (int col1 = 0; col1 < (int) col; col1++) {
                if (matrix[row1][col1]== '<'){
                    System.out.printf("<td>&lt;</td>");
                } else if (matrix[row1][col1] == '>'){
                    System.out.printf("<td>&gt;</td>");
                }else if (matrix[row1][col1] == '"') {
                    System.out.printf("<td>&quot;</td>");
                } else {
                    System.out.printf("<td>%s</td>", "" + matrix[row1][col1]);
                }

            }
            System.out.printf("</tr>");
            if (row1 == (int) row - 1) {
                System.out.printf("</table>");
            }
        }

    }
}
