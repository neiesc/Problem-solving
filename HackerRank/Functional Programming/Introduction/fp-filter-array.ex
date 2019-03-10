# Filter Array
# https://www.hackerrank.com/challenges/fp-filter-array/problem

defmodule Implementation do
    def while(delimiter) do
        n = IO.gets("")
        if n == :eof do
            "exit"
        else
            n = String.trim_trailing(n) |> String.to_integer
            if n < delimiter do
                IO.puts n
            end
            while(delimiter)   
        end
    end
end

defmodule Solution do
    delimiter = IO.gets("") |> String.trim_trailing |> String.to_integer
    Implementation.while(delimiter)
end
