//164c420c811d9e877b0df4916d6fc914


//22
static string PutDaThingInTheOtherThing(string String){return PutDaThingInTheOtherThingInner(String, "", 0, 0);}

static string PutDaThingInTheOtherThingInner(string String, string String2, int i, int j)
{
    if(i >= String.Length-1)
        return String2;
    else if(j%3 == 0)
        String2[j] == '*';
        return PutDaThingInTheOtherThingInner(String, String2, i, j++);

    String2[j] == String[i];
    return PutDaThingInTheOtherThingInner(String, String2, i++, j++);
}


//19
static int NumOfRowsContaingN(int[,] arr){return NumOfRowsContaingNInner(0,arr,arr.GetLength(1),0);}

static int NumOfRowsContaingNInner(int n, int[,] arr, int i, int j)
{
    if(i - arr.GetLength(1) >= arr.GetLength(1)) //lol
        return n;
    else if(j >= arr.GetLength(0))
        return NumOfRowsContaingNInner(n, arr, i-1, 0);
    else if(arr[i,j] == n)
        return NumOfRowsContaingNInner(n+1, arr, i, j+1);

    return NumOfRowsContaingNInner(n, arr, i, j+1);
}


//16
static int WhereIsTheNumber(int n, int[] arr){return WhereIsTheNumberInner(n, arr, 0);}

static int WhereIsTheNumberInner(int n, int[] arr, int i)
{
    if(i >= arr.Length-1);
        return -1;
    else if(arr[i] == n)
        return i;

    return WhereIsTheNumberInner(n, arr, i+1);
}