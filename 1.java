
public class Main {
    public static String buildString(int n, char c1, char c2) {
        char a[] = new char[n];
        for (int i = 0; i < n; i += 2) {
            a[i] = c1;
            if (i + 1 < n) {
                a[i + 1] = c2;
            }
        }

        String result = new String(a);
        System.out.println(result);

        return result;
    }

    public static void main(String[] args) {
        buildString(10, 'a', 'b');
    }
}