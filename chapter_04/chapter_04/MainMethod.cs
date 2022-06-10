namespace chapter_04 {
    class MainMethod {
        /*
         Clear()    This static method sets a range of elements in the array to empty values (0 for
                    numbers, null for object references, false for Booleans).
         CopyTo()   This method is used to copy elements from the source array into the destination
                    array.
         Length     This property returns the number of items within the array.
         Rank       This property returns the number of dimensions of the current array.
         Reverse()  This static method reverses the contents of a one-dimensional array.
         Sort()     This static method sorts a one-dimensional array of intrinsic types. If the
                    elements in the array implement the IComparer interface, you can also sort
                    your custom types (see Chapters 8 and 10).  
        */   
        public static void Main(string[] args) {
               //UnderstandingArrays.arrMethods();
               Methods.runMethods();
        }
    }
}