input_str = input()
key_value_pairs = input_str.split()
tp = tuple(map(lambda x: tuple(x.split("=")), key_value_pairs))
print(tp)