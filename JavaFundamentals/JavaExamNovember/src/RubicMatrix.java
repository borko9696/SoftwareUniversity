import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 16/11/2015.
 */
public class RubicMatrix {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] rAndC = sc.nextLine().split(" ");
        int r = Integer.parseInt(rAndC[0]);
        int c = Integer.parseInt(rAndC[1]);
        int[][] matrix = new int[r][c];
        int[][] clone = new int[r][c];

        int count = 1;
        int cloneCount = 1;
        for (int row = 0; row < r; row++) {
            for (int col = 0; col < c; col++) {
                matrix[row][col] = count;
                clone[row][col] = cloneCount;
                count++;
                cloneCount++;
            }
        }

        int comandNum = Integer.parseInt(sc.nextLine());
        List<String> listComand = new ArrayList<>();
        for (int i = 0; i < comandNum; i++) {
            String comand = sc.nextLine();
            listComand.add(comand);
        }

        for (int i = 0; i < listComand.size(); i++) {
            String[] arr = listComand.get(i).split(" ");
            int rowOrCol = Integer.parseInt(arr[0]);
            int moveTimes = Integer.parseInt(arr[2]);
            String move = arr[1];

            if (move.equals("right")) {
                for (int j = 0; j <moveTimes; j++) {
                    int last = clone[rowOrCol][c-1];
                    for( int index =c-2; index >= 0 ; index-- ) {
                        clone[rowOrCol][index+1] = clone[rowOrCol][index];
                    }
                    clone[rowOrCol][0]=last;
                }
            } else if (move.equals("left")) {
                for (int j = 0; j < moveTimes; j++) {
                    int first = clone[rowOrCol][0];
                    for (int index = 0; index < c-1; index++) {
                        clone[rowOrCol][index] = clone[rowOrCol][index+1];
                    }
                    clone[rowOrCol][c-1]=first;
                }

            } else if (move.equals("down")) {
                for (int j = 0; j <moveTimes; j++) {
                    int last = clone[r-1][rowOrCol];
                    for( int index =r-2; index >= 0 ; index-- ) {
                        clone[index+1][rowOrCol] = clone[index][rowOrCol];
                    }
                    clone[0][rowOrCol]=last;
                }
            }else if (move.equals("up")) {
                for (int j = 0; j < moveTimes; j++) {
                    int first = clone[0][rowOrCol];
                    for (int index = 0; index < r-1; index++) {
                        clone[index][rowOrCol] = clone[index+1][rowOrCol];
                    }
                    clone[r-1][rowOrCol]=first;
                }
            }
        }

        for (int i = 0; i < r; i++) {
            for (int j = 0; j <c; j++) {
                if (matrix[i][j]==clone[i][j]) {
                    System.out.println("No swap required");
                }else {
                    for (int k = 0; k <r ; k++) {
                        for (int l = 0; l <c ; l++) {
                            if (matrix[i][j] == clone[k][l]) {
                                int temp = clone[k][l];
                                clone[k][l]=clone[i][j];
                                clone[i][j]=temp;
                                System.out.printf("Swap (%d, %d) with (%d, %d)\n",i,j,k,l);
                            }
                        }
                    }
                }
            }
        }
    }
}
