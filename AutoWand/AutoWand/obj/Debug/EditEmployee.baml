   M S B A M L   `   `   `  ����C  ?AutoWand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutoWandAutoWand  5   	       AutoWand.EditEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AutoWand     5   	     � Title$  Edit Employee - AutoWand��5   	   $	��350��6*   $	��400��67   .��5	      � -   5         �Name$ 
ParentGrid��5	       � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��1��6   $��0��6    $��Right=�6-   $��Center=�6I   $��	Username:��6d   �� 5   
   $��1��6   $��1��6    $��Right=�6-   $��Center=�6I   $��	Password:��6d   �� 5   
   $��1��6   $��2��6    $��Right=�6-   $��Center=�6I   $��Confirm Password:��6d   �� 5   
   $��1��6   $��3��6    $��Right=�6-   $��Center=�6I   $��Permission Level:��6d   �� 5   
   -   5         ��Name$ PermissionError��5   e   $��3��6   $��4��6    $��Center=�6-   
���  ��$��*��6Y   $y�Hidden=�6~   �� 5   
   -   5         ��Name$ UsernameEntry��5   _    �� 	MaxLength$ 20��63   $��2��6B   $��0��6R   $	��185��6v   $��20��6�   G� 5   
   -   5         G�Name$ PasswordEntry��5   g    G� 	MaxLength$ 20��6;   $��2��6J   $��1��6Z   $	��185��6~   $��20��6�   G� 5    
   -   5        $ PasswordConfirmEntry��5    g   $ 20��6;   $��2��6J   $��2��6Z   $	��185��6�   $��20��6�   �� 5!   
   -   5        	 ��Name$	 PermissionSelector��5!   3   $��2��6   $��3��6&   $	��185��6O   $��22��6[   6�   �� 5#   
   $��1��6   $��4��6%   
 �� Orientation$
 
Horizontal=�62   $��Center=�6K   $��2��6h   .+�5$      �� -   5        $��Edit Account��5$      $	��120��6,   $��22��68   $��5q�6D    �� 	IsDefault . 6j   �� 5%      -   5        $��Cancel��5%      $	��120��6&   $��22��62   $��5q�6>    �� IsCancel . 6]   5&      5'      5(      