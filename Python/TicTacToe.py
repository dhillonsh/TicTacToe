from random import randint

print("\n" + 'Tic-Tac-Toe Game:' + "\n")
while(True):
        board = [0,1,2,3,4,5,6,7,8]
        def showBoard():
                print(board[0],'|',board[1],'|',board[2])
                print(board[3],'|',board[4],'|',board[5])
                print(board[6],'|',board[7],'|',board[8])
        def checkBoard(c):
                if(board[0] == c and board[1] == c and board[2] == c):
                        return 1
                elif(board[3] == c and board[4] == c and board[5] == c):
                        return 1
                elif(board[6] == c and board[7] == c and board[8] == c):
                        return 1
                elif(board[0] == c and board[3] == c and board[6] == c):
                        return 1
                elif(board[1] == c and board[4] == c and board[7] == c):
                        return 1
                elif(board[2] == c and board[5] == c and board[8] == c):
                        return 1
                elif(board[0] == c and board[4] == c and board[8] == c):
                        return 1
                elif(board[2] == c and board[4] == c and board[6] == c):
                        return 1
			
        print('You are [x] and I am [o]' + "\n")
        showBoard()
        while True:
                choice = input('Choose a position [0-8]: ')
                if(not choice.isdigit()):
                        continue
                choice = int(choice)
                if(board[choice] == 'x' or board[choice] == 'o'):
                        print('This spot has already been taken.')
                        continue
                board[choice] = 'x'
                if(checkBoard('x') == 1):
                        showBoard()
                        input('Congratulations, you have won the game!')
                        break
                end = 1
                for x in board:
                        if(x != 'x' and x != 'o'):
                                end = 0
                if(end == 1):
                        input('No more moves can be made, the game has been ended.')
                        break
                while(True):
                        rand = randint(0,8)
                        if(board[rand] != 'x' and board[rand] != 'o'):
                                board[rand] = 'o'
                                break
                        else:
                                continue;
                showBoard()
                if(checkBoard('o') == 1):
                        input('You have lost!')
                        break
                
