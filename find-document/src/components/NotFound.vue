 <template>
    <div class="row">
        <div class="col-md-12">
            <div class="error-template">
                <h1>
                    XIN LỖI!!!</h1>
                <h2>
                trang web đang gặp sự cố</h2>
                <div class="error-details">
                  Chúng tôi đang cố gắng để khắc phục nó
                </div>
                <div class="error-actions">
                    <router-link :to="{ name: 'home'}" class="nav-link"><h2> Về lại Trang chủ nhé!!</h2></router-link>
                </div>
            </div>
        </div>
    </div>
</template>
<style scoped>
    .error-template {padding: 40px 15px;text-align: center;}
    .error-actions {margin-top:15px;margin-bottom:15px;}
    .error-actions .btn { margin-right:10px; }
</style>
