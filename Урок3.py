import java.util.ArrayList;
import java.util.List;

public class Homework {

    public static void main(String[] args) {
        List<String> strings = new ArrayList<>();
        strings.add("string");
        strings.add("40");
        strings.add("-5");
        strings.add("my_string");
        System.out.println(strings); // [string, 40, -5, my_string]
        //removeEvenNumber(strings);
        removeWholeNumber(strings);
        System.out.println(strings); // [string, -5, my_string]
    }

    static void removeEvenNumber(List<String> strings) {
        // Удалить все четные элементы из списка
        strings.removeIf(s -> {
            try {
                int num = Integer.parseInt(s);
                return num % 2 == 0;
            } catch (NumberFormatException e) {
                return false;
            }
        });
    }
    
    static void  removeWholeNumber(List<String> strings){
        //Удалить строки, которые являются целыми числами
        strings.removeIf(s-> {
            try {
                int num = Integer.parseInt(s);
                return num/1 == num;
            } catch (NumberFormatException e){
                return false;
            }
        });
    }
}