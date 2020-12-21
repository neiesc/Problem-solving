highest_seat_id = 0

with open("input.txt", "r") as f:
    lines = [line.rstrip() for line in f.readlines()]
    for line in lines:
        rows = [0, 127]
        row = None
        columns = [0, 7]
        column = None

        for command in list(line):
            if command == "F":
                rows = [rows[0], ((rows[1] - rows[0]) // 2) + rows[0]]
            elif command == "B":
                rows = [((rows[1] - rows[0]) // 2) + rows[0] + 1, rows[1]]
            elif command == "L":
                columns = [columns[0], ((columns[1] - columns[0]) // 2) + columns[0]]
            elif command == "R":
                columns = [((columns[1] - columns[0]) // 2) + columns[0] + 1, columns[1]]

        if rows[0] == rows[1]:
            row = rows[0]

        if columns[0] == columns[1]:
            column = columns[0]

        seat_id = row * 8 + column
        if seat_id > highest_seat_id:
            highest_seat_id = seat_id
        #print(f"line: {line}, row: {row}, column: {column}, seat ID: {seat_id}")

print(f"\nWhat is the highest seat ID on a boarding pass? {highest_seat_id}")
