var records = [];

function record(order_id) {
  records.push(order_id);
}

function get_last(i) {
  return records.splice(i + 1);
}

record(1);
record(2);
record(3);
record(4);
record(5)
get_last(2); //[ 4, 5 ]