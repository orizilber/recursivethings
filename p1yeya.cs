static string LettersWithin(char a, char b)
{
    if(a-b==0)
        return "";

    return "" + LettersWithin(a, b-1);
}

static string LettersSmallerThenNext(int[] arr, int i)
{
    if(i >= arr.Length-1)
        return "";

    else if(arr[i] > arr[i+1])
        return "" + arr[i] + LettersSmallerThenNext(arr, i+1);

    return "" + LettersSmallerThenNext(arr, i+1);
}

