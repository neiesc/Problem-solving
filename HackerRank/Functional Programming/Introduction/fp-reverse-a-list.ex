# Reverse a List
# https://www.hackerrank.com/challenges/fp-reverse-a-list/problem

defmodule Implementation do
    def while(r) do
        n = IO.gets("")
        if n == :eof do 
            for i <- Enum.reverse(r), do: IO.puts i
            "exit"
        else
            n = String.trim_trailing(n) |> String.to_integer
            while(r ++ [n])
        end
    end
end

defmodule Solution do
    Implementation.while([])
end