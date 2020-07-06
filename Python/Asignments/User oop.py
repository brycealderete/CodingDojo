class user:
    def __init__(self,name):
        self.name = name 
        self.balance = 1000
    def __repr__(self):
        return f'Name:{self.name}\nBalance:{self.balance}'
    def make_withdraw(self,amount):
        if self.balance<amount:
            print(f"Cannot make withdraw as your balance is less then {amount}")
            return False 
        self.balance = self.balance-amount
        return self
    def display_user_balance(self):
        return f'{self.name} balance is {self.balance}'
    def transfer_money(self,other_user,amount):
        if self.balance<amount:
            print(f"Cannot make transfer as your balance is less then {amount}")
            return False 
        self.balance= self.balance-amount
        other_user.balance=other_user.balance +amount
        return self

jim=user('Jim')
bryce= user('Bryce')

bryce.make_withdraw(30).make_withdraw(30).make_withdraw(30).make_withdraw(30)


print(bryce.display_user_balance())
print(jim)