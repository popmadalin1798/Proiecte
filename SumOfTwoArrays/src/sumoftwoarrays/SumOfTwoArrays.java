/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sumoftwoarrays;

import java.util.HashSet;
import java.util.Set;
//function that finds if the sum of an element from first and an element from second array match a value given.Time complexity:N+N
/**
 *
 * @author Pop Madalin-Emilian
 */
public class SumOfTwoArrays {
    public Boolean SumOfTwo(int [] a,int[] b,int v)
    {
        Set<Integer> diff=new HashSet<>();//hashset that retains the value of difference between the value given and the elements from the first array
        for(int i=0;i<a.length;i++)//for loop going through the a array
        {
            int difference=v-a[i];//retain the value of difference between the value given and the element of index i of the array
            diff.add(difference);//add the difference to the diff hashset
        }
        for(int i=0;i<b.length;i++)//for loob going thorugh the elements of b array
        {
            if(diff.contains(b[i]))//if the value of index i of the array matches a value from the diff hashset
            {
                return true;//we return true,the value v given and be obtain from the sum of two elements from array a and b
            }
        }
        return false;//if we don't find a match,we return false
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        SumOfTwoArrays sot=new SumOfTwoArrays();//we initiliaze our class with the default constructor
        int [] a={1,2,3,4};//exemple of array a
        int [] b={0,7,8,4};//exemple of array b
        int v=2;//exemple of a value give to obtain the sum from the 2 arrays
        System.out.println(sot.SumOfTwo(a, b, v));//print the result
    }
    
}
