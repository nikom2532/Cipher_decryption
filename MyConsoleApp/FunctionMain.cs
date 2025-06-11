using System;

namespace MyConsoleApp
{
  class FunctionMain
  {
    static void Main(string[] args)
    {
        // Caesar Cipher
        // String _ANSWER_String_Cipher_decrypt = "This is English";
        //--------------------------------------------------------

        String String_Cipher = "Rfgq gq Clejgqf";
        String String_Cipher_Keyword = "English";
        String String_Cipher_decrypt = "";

        String[] Array_Word_Cipher = String_Cipher.Split(' ');
        int DiffCharNumber = 0;
        int IndexOfArray_Word_Cipher = 0;

        for(int i = 0; i < Array_Word_Cipher.Length; i++)
        {
            if(String_Cipher_Keyword.Length == Array_Word_Cipher[i].Length){
                int[] temp_DiffChar = new int[String_Cipher_Keyword.Length];
                bool IsCipher = false;
                if(String_Cipher_Keyword.Length == 1){
                    break;
                }
                else{
                    for(int j = 0; j < Array_Word_Cipher[i].Length; j++){
                        temp_DiffChar[j] = (((int)Array_Word_Cipher[i][j]) - ((int)String_Cipher_Keyword[j]));
                        if(j != 0){
                            
                            if((temp_DiffChar[j-1] != temp_DiffChar[j])){
                                break;
                            }
                            else if(j == Array_Word_Cipher[i].Length - 1){
                                IsCipher = true;
                                DiffCharNumber = temp_DiffChar[j];
                            }
                        }
                    }
                    if(IsCipher){
                        IndexOfArray_Word_Cipher = i;
                        break;
                    }
                }
            }
        }
        for(int i = 0; i < String_Cipher.Length; i++){
            if(String_Cipher[i] == ' '){
                String_Cipher_decrypt += " ";
            }
            else{
                char c = (char) ((int) String_Cipher[i] - DiffCharNumber);
                String_Cipher_decrypt += c;
            }
        }
        Console.WriteLine("{0}", String_Cipher_decrypt);

    }
  }
}