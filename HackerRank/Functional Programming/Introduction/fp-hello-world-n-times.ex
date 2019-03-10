# Hello World N Times
# https://www.hackerrank.com/challenges/fp-hello-world-n-times/problem

defmodule Solution do
    n = IO.gets("") |> String.to_integer
    for n <- 1..n, do: IO.puts "Hello World"
end
