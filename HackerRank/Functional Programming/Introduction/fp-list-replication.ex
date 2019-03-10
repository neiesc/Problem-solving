# List Replication
# https://www.hackerrank.com/challenges/fp-list-replication/problem

defmodule Implementation do
    def while(total) do
        n = IO.gets("")
        if n == :eof do
            "exit"
        else
            n = String.trim_trailing(n) |> String.to_integer
            for _ <- 1..total, do: IO.puts n
            while(total)   
        end
    end
end

defmodule Solution do
    total = IO.gets("") |> String.trim_trailing |> String.to_integer
    Implementation.while(total)
end
