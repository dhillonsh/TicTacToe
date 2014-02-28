#Harpreet Dhillon
# 5-17-13

puts "Tic-Tac-Toe [Ruby]"

def print_board(board)
    puts(board[0].to_s + ' | ' + board[1].to_s + ' | ' + board[2].to_s)
    puts(board[3].to_s + ' | ' + board[4].to_s + ' | ' + board[5].to_s)
    puts(board[6].to_s + ' | ' + board[7].to_s + ' | ' + board[8].to_s)
end
def check_board(c,board)
	if board[0] == c and board[1] == c and board[2] == c
		return true
	elsif board[3] == c and board[4] == c and board[5] == c
		return true
	elsif board[6] == c and board [7] == c and board[8] == c
		return true
	elsif board[0] == c and board[3] == c and board[6] == c
		return true
	elsif board[1] == c and board[4] == c and board[7] == c
		return true
	elsif board[2] == c and board[5] == c and board[8] == c
		return true
	elsif board[0] == c and board[4] == c and board [8] == c
		return true
	elsif board[2] == c and board[4] == c and board[6] == c
		return true
	else
		return false
	end
end


	board = [0,1,2,3,4,5,6,7,8]
	puts('You are [x] and I am [o]' + "\n")
	print_board(board)
	while true
		puts('Choose a position [0-8]: ')
		choice = Integer(gets.chomp[0]) rescue nil
		while(choice == nil)
			puts("You must enter a number [0-8]: ")
			choice = Integer(gets.chomp[0]) rescue nil
		end
		
		choice = Integer(choice)
        if(!board[choice])
            puts('That spot does not exist! Choose a position [0-8]:')
    	    choice = Integer(gets.chomp[0]) rescue nil
            while(choice == nil)
    		 	puts("You must enter a number [0-8]: ")
			choice = Integer(gets.chomp[0]) rescue nil
		    end
        end
		if(board[choice] == 'x' or board[choice] == 'o')
            
			puts('This spot has already been taken. Choose a position [0-8]:')
            choice = Integer(gets.chomp[0]) rescue nil
            while(choice == nil)
    		    	puts("You must enter a number [0-8]: ")
			choice = Integer(gets.chomp[0]) rescue nil
		    end
		end
		board[choice] = 'x'
		if(check_board('x', board) == true)
			print_board(board)
			puts('Congratulations, you have won the game!')
			break
		end
		stop = 1
		for x in board
			if(x != 'x' and x != 'o')
				stop = 0
			end
		end
		if(stop == 1)
			puts('No more moves can be made, the game has been ended.')
            		print_board(board)
			break
		end
		while(true)
			rand = rand(8)
			if(board[rand] != 'x' and board[rand] != 'o')
				board[rand] = 'o'
				break
			end
		end
		print_board(board)
		if(check_board('o', board) == true)
			puts('You have lost!')
			break
		end
	end