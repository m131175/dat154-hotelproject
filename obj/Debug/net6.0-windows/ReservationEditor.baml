   M S B A M L   `   `   `  ����D  @FrontDesk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FrontDesk	FrontDesk  5   	   !    FrontDesk.ReservationEditor   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FrontDesk     5   	     � Title$  ReservationEditor��5   	   $	��450��6#   $	��800��60   .��5
      � .+�5   
   �� $��End date��6   $
��Left=�6#   $��	534,7,0,0q�6>   $	��Top=�6Q   �� 5   
   $��
Start date��6   $
��Left=�6%   $��	397,7,0,0q�6@   $	��Top=�6S   �� 5   
   $��Room number��6   $
��Left=�6&   $��	241,7,0,0q�6A   $	��Top=�6T   �� 5   
   $��Reservation Username��6   $
��Left=�6/   $��	108,7,0,0q�6J   $	��Top=�6]   �� 5   
   -   5        $��
resRoomNum��5      $
��Left=�6$   $��
241,38,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��120��6�   �� 5   
   -   5        $��resUsername��5      $
��Left=�6%   $��
108,38,0,0q�6@   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $��	addResBtn��5      $	��Add��6"   $
��Left=�60   $��	10,85,0,0q�6K   $	��Top=�6^   $��25��6v   $��89��6�   6�   �� 5   
   -   5        $��updateResBtn��5      $��Update��6%   $
��Left=�66   $��
104,85,0,0q�6Q   $	��Top=�6e   $��25��6}   $��89��6�   
 � Tag 6�   �� �� 5   
   -   5        $��	delResBtn��5      $��Delete��6"   $
��Left=�63   $��
198,85,0,0q�6N   $	��Top=�6b   $��25��6z   $��89��6�    6�   �� (  "System.Windows.Controls.DatePicker  5   
   -   5        $��resStartDate��5      $
��Left=�6)   $��
377,35,0,0q�6D   $	��Top=�6X     5   
   -   5        $��
resEndDate��5      $
��Left=�6'   $��
512,35,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $��statusDropdown��5      $
��Left=�6)   $��
640,36,0,0q�6D   $	��Top=�6X   $	��120��6p   ��6|   �� *ReservationStatuses+5      �� 5   
   $��Status��6   $
��Left=�6!   $��
681,10,0,0q�6<   $	��Top=�6P   �� 5   
   $��Id��6   $
��Left=�6   $��44,5,0,0q�68   $	��Top=�6J    J� RenderTransformOrigin$ -0.987,0.502&�6b   �� 5   
   -	   5        $��resId��5      $
��Left=�6   $��	36,38,0,0q�6:   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $��37��6�   
������� �� 
IsReadOnly$
 True��6�   5      5      