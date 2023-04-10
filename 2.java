import java.io.*;

public class Main {
    public static void main(String[] args) {
        File file = new File("file.txt");
        if (!file.exists()) {
            try {
                file.createNewFile();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        
        try {
            FileWriter writer = new FileWriter(file);
            BufferedWriter bufferedWriter = new BufferedWriter(writer);
            
            for (int i = 0; i < 100; i++) {
                bufferedWriter.write("TEXT");
            }
            
            bufferedWriter.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}