function confirmDelete(uniqueid, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueid;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueid;  

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}