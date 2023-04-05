import java.util.Random;

public class Homework{

    public static void main(String[] args){

        System.out.println(isSumBetween10And20(5, 15)); // true
        System.out.println(isSumBetween10And20(7, 15)); // false
        System.out.println(isSumBetween10And20(2, 6)); // false
    
        System.out.println(isPositive(5)); // true
        System.out.println(isPositive(-3)); // false
    
    
        printString("abcd", 5); // abcdabcdabcdabcdabcd
        
    
    createArray(10);
}

    createArray(5, 10);
    isLeapYear(2023);
    
       int[][] array = new int[4][4]; // [[1, 0, 0, 0], [0, 1, 0, 0], [0, 0, 1, x], [0, 0, 0, 1]]
        int x = array[2][3];
    }
    

    private static boolean isSumBetween10And20(int a, int b) {
        int c = a + b;
        if (c >= 10 && c <= 20) {
            return true;
        } else {
            return false;
        }
    }
    
    private static boolean isPositive(int x) {
        if(x>0) return true;
        else return false;
    }
    
    private static void printString(String source, int repeat) {
        for(int i=0;i<repeat;i++){
        System.out.println(source);
        }
    }
    
    private static boolean isLeapYear(int year){
        if ((year/4==0 && year%100!=0) || year%4000==0) return true;
        else return false;
    }
    
    private static int[] createArray(int len, int initialValue){
        int[] array=new int[len];
        for(int i=0;i<len;i++){
            array[i]=initialValue;
            System.out.print(array[i] + " ");
        }
        
        return array;
    }
    
    
    
     public static int[] createArray(int len){
        int[] array = new int[len];
        Random random = new Random();
        
        for(int i=0;i<len;i++){
            array[i] = random.nextInt(2);
        }
        
        for(int i=0;i<len;i++){
            System.out.print(array[i] + " ");
        }
        
        System.out.println();
        
        for(int i=0;i<len;i++){
            if (array[i]==1) array[i]=0;
            else if(array[i]==0) array[i]=1;
        }
        
        for(int i=0;i<len;i++){
            System.out.print(array[i] + " ");
        }
        return array;
    }
    
    }

    /*
      
      2. Задать массив [ 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 ] пройти по нему циклом, и числа меньшие 6 умножить на 2;
     
      3. Создать квадратный двумерный целочисленный массив (количество строк и столбцов одинаковое),
      и с помощью цикла(-ов) заполнить его диагональные элементы единицами (можно только одну из диагоналей, если обе сложно).
      Определить элементы одной из диагоналей можно по следующему принципу: индексы таких элементов равны, то есть [0][0], [1][1], [2][2], …, [n][n];
      Также заполнить элементы побочной диагонали*/
     
    
