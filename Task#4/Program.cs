string [] array = {"1234","1","12f","124412","2"};
string [] array1 = Array3Simbol(array);

ArrayOut(array1);
void ArrayOut(string [] array){
for (int i=0; i<array.Length;i++){
    System.Console.WriteLine(array[i]);
}
}

string [] Array3Simbol(string [] array){
    int count=0;
    for(int i=0; i<array.Length;i++){
        if (array[i].Length<=3)
        count++;
    }
    string [] array1 = new string [count];
    int j=0;
    for(int i=0; i<array.Length;i++){
        if (array[i].Length<=3)
        {array1[j] = array[i];
        j++;}
    }
    return array1;
}