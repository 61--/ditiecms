--�ͷ��α� DEALLOCATE cursor_1
--���һ��������ģ��Ȩ�޿���
declare cursor_1 cursor for  
select moduleID from dt_modules where moduledepth<3
open cursor_1

declare @moduleID varchar(8)
fetch next from cursor_1 into @moduleID

while @@fetch_status <> -1
begin
insert into dt_moduleControl values('�鿴',@moduleID,1,0)
fetch next from cursor_1 into @moduleID
end
close cursor_1
--�������ģ��Ȩ�޿���
declare cursor_2 cursor for  
select moduleID from dt_modules where moduledepth=3
open cursor_2

declare @moduleID varchar(8)
fetch next from cursor_2 into @moduleID

while @@fetch_status <> -1
begin
insert into dt_moduleControl values('�鿴',@moduleID,1,1)
insert into dt_moduleControl values('���',@moduleID,2,2)
insert into dt_moduleControl values('�༭',@moduleID,4,3)
insert into dt_moduleControl values('ɾ��',@moduleID,8,4)
fetch next from cursor_2 into @moduleID
end
close cursor_2