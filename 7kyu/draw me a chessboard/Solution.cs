using System;

using System.Numerics;

namespace Solution{
    public static class Kata {
        public static char[][] chessBoard(int row, int col) {                
            char[][] res = new char[row][];
            for(int i = 0; i < row; i++)
            {      
                res[i] = new char[col];                            
                for(int j = 0; j< col; j++)
                    res[i][j] = ((j+i)%2 == 0 ? 'O' : 'X');
            }
            return res;
        }
    }
}