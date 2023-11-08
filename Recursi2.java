public class Recursi2 {

    // Input array of digits and one index in the array
    // The function is counts the number of positive digits
    public static int Q20(int[] array, int index) {

        //stop conditions: if the index equal to 0, then we checked all the digits
        if(index < 0)
            return 0;

        //Counting the positive digits in the array
        if(array[index] > 0)
            return (1 + Q20(array, index - 1));

        return (Q20(array, index - 1));
    }

    // Input of one string
    // The function is counts the number of lower case chars in the string
    public static int Q31(String str){

        //stop conditions: if the string is empty, so we checked all the chars in the strings
        if(str.isEmpty())
            return 0;

        //Counting the number of the lower case chars (all the lower case char are between the number 96 and 123 in ascii)
        if(str.charAt(0) > 96 && str.charAt(0) < 123)
            return (1 + Q31(str.substring(1)));

        return (Q31(str.substring(1)));
    }

    public static void main(String[] args) {
        // First check of the first question
        System.out.println("First check of the first question:");
        System.out.println("Input: array(1,5,3,7,3,9,4), index(6)");
        System.out.println("The correct output is: 7.");
        int[] array1 = {1,5,3,77,3,9,4};
        System.out.println("The output is:" + Q20(array1, 6) + "\n");

        //Second check of the first question
        System.out.println("Second check of the first question:");
        System.out.println("Input: array(1,5,-3,77,0,3,-9,4), index(7)");
        System.out.println("The correct output is: 5.");
        int[] array2 = {1,5,-3,77,0,3,-9,4};
        System.out.println("The output is:" + Q20(array2, 7) + "\n");

        //Third check of the first question
        System.out.println("Third check of the first question:");
        System.out.println("Input: array(-1,-5,-3,-77,0,-3,-9,-4), index(7)");
        System.out.println("The correct output is: 0.");
        int[] array3 = {-1,-5,-3,-77,0,-3,-9,-4};
        System.out.println("The output is:" + Q20(array3, 7) + "\n");

        //First check of the second question
        System.out.println("First check of the second question:");
        System.out.println("Input: str(asdirjfkg)");
        System.out.println("The correct output is: 9.");
        System.out.println("The output is:" + Q31("asdirjfkg") + "\n");

        //Second check of the second question
        System.out.println("Second check of the second question:");
        System.out.println("Input: array(dutkDRhDEdEE)");
        System.out.println("The correct output is: 6.");
        System.out.println("The output is:" + Q31("dutkDRhDEdEE") + "\n");

        //Third check of the second question
        System.out.println("Third check of the second question:");
        System.out.println("Input: array(DYTFDRGDDS)");
        System.out.println("The correct output is: 0.");
        System.out.println("The output is:" + Q31("DYTFDRGDDS") + "\n");


    }
}

// The output of the program
/*

First check of the first question:
Input: array(1,5,3,7,3,9,4), index(6)
The correct output is: 7.
The output is:7

Second check of the first question:
Input: array(1,5,-3,77,0,3,-9,4), index(7)
The correct output is: 5.
The output is:5

Third check of the first question:
Input: array(-1,-5,-3,-77,0,-3,-9,-4), index(7)
The correct output is: 0.
The output is:0

First check of the second question:
Input: str(asdirjfkg)
The correct output is: 9.
The output is:9

Second check of the second question:
Input: array(dutkDRhDEdEE)
The correct output is: 6.
The output is:6

Third check of the second question:
Input: array(DYTFDRGDDS)
The correct output is: 0.
The output is:0

*/