import java.util.Scanner;
import java.util.Stack;

public class StringRecorder {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Stack<String> storage = new Stack<>();
        
        while (true) {
            String input = scanner.nextLine();
            if (input.equals("print")) {
                while (!storage.isEmpty()) {
                    System.out.println(storage.pop());
                }
            } else if (input.equals("revert")) {
                if (!storage.isEmpty()) {
                    storage.pop();
                }
            } else if (input.equals("exit")) {
                break;
            } else {
                storage.push(input);
            }
        }
    }
}