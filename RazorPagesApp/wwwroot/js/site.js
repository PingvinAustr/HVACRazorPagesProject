
function SwitchTab(go_to_tab_number) {
    //sessionStorage.setItem('go_to_tab_number', go_to_tab_number);
    //alert(sessionStorage.getItem('go_to_tab_number'));
    document.cookie = "go_to_tab_number=" + go_to_tab_number;
    //alert(document.cookie);
    document.location.reload();
}