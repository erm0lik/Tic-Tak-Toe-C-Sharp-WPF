   M S B A M L   `   `   `  ????F  BTic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tic_Tac_ToeTic_Tac_Toe  5   	   $    Tic_Tac_Toe.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tic_Tac_Toe     5   	     ? Title$  Реєстрація??5   	   $	??200??6   $	??185??6)    ? 
ResizeMode$ NoResize=?5	   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??20px ?6   6-   ?? 5      6   ?? 5      $
??30px ?6   6,   .+?5   
   ?? $??0??6   $??Center=?6!    ?? TextAlignment$ Center=?6<   $??Center=?6S   $??20??6p   $	??185??6|   $??10(?6?   ;9Введіть дані користувача нижче6?   ? 5   
   $??1??6    5      ?? 5      6"   ?? 5      6"   ?? 5      6"   ?? 5      6"   .+?5   
   ?? $??Center=?6   $??0??61   $??NoWrap=?6>   $	??Top=?6T   $ Center=?6l   $??Ім'я:??6?   $??20??6?   $	??100??6?   $??12(?6?   ?? 5   
   -   5         ??Name$ UserName??5      $??1??6$   $??20??61   $	??100??6=    ?? 	MaxLength$ 20??6I   ?? 5   
   $??Center=?6   $??2??62   $
??Wrap=?6?   $	??Top=?6S   $ Center=?6k   $??20??6?   $	??100??6?   $
??12px(?6?   $??Тип акаунту??6?   6?   ?? 5   
   -   5         ??Name$ TypeAccount??5      $??3??6(   $??100px??65   $
??20px??6C   $	??Top=?6Q   .@?5      ?? Преміум аккаунт6)   ?? 5       Базовий аккаунт6)   ?? 5!      +)Безпрограшний аккаунт63   5"      5#      ?? 5$   
   -   5        $??Center=?5$      $??2??6/   $??Center=?6<   $
??20px??6W   $	??120??6e   $$??Зареєструватися??6?   $??12(?6?   6?   5%      5&      