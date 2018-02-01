<template>
    <section id="ourStaff" class="parallax">
        <div class="parallax-overlay">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="section-content text-center">
                            <h2>Meet our Staff</h2>
                            <hr class="botm-line" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <h4>Alexandria, VA</h4>
                    </div>                    <div class="col-sm-3" v-for="(profile, index) in profiles" v-if="profile.location === 1" :key="profile.name">
                        <div class="card hovercard">
                            <div class="cardheader">
                            </div>
                            <div class="avatar">
                                <img alt="" :src="profile.imagePath">
                            </div>
                            <div class="info">
                                <div class="title">
                                    <a target="_blank" href="">{{profile.name}}</a>
                                </div>
                                <div class="desc">{{profile.title}}</div>
                                <div class="desc" v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</div>
                            </div>
                            <div class="bottom">
                                <button type="button" class="btn btn-default" data-toggle="modal" :data-target="'#' + index">View Profile</button>
                            </div>
                        </div>
                        <div :id="index" class="modal fade" role="dialog">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <div class="col-md-12">
                                            <div class="info">
                                                <h1>{{profile.name}}</h1>
                                                <h4>{{profile.title}}</h4>
                                                <h4 v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</h4>
                                            </div>
                                            <div id="aboutMe">
                                                <div class="text-center">
                                                    <hr class="botm-line" />
                                                </div>
                                                <h4>About {{profile.name}}</h4>
                                                <div v-html="profile.bio"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <h4>Woodbridge, VA</h4>
                    </div>                    <div class="col-sm-3" v-for="(profile, index) in profiles" v-if="profile.location === 2" :key="profile.name">
                        <div class="card hovercard">
                            <div class="cardheader">
                            </div>
                            <div class="avatar">
                                <img alt="" :src="profile.imagePath">
                            </div>
                            <div class="info">
                                <div class="title">
                                    <a target="_blank" href="">{{profile.name}}</a>
                                </div>
                                <div class="desc">{{profile.title}}</div>
                                <div class="desc" v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</div>
                            </div>
                            <div class="bottom">
                                <button type="button" class="btn btn-default" data-toggle="modal" :data-target="'#' + index">View Profile</button>
                            </div>
                        </div>
                        <div :id="index" class="modal fade" role="dialog">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <div class="col-md-12">
                                            <div class="info">
                                                <h1>{{profile.name}}</h1>
                                                <h4>{{profile.title}}</h4>
                                                <h4 v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</h4>
                                            </div>
                                            <div id="aboutMe">
                                                <div class="text-center">
                                                    <hr class="botm-line" />
                                                </div>
                                                <h4>About {{profile.name}}</h4>
                                                <div v-html="profile.bio"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        <h4>Fredericksberg, VA</h4>
                    </div>
                    <div class="col-sm-3" v-for="(profile, index) in profiles" v-if="profile.location === 3" :key="profile.name">
                        <div class="card hovercard">
                            <div class="cardheader">
                            </div>
                            <div class="avatar">
                                <img alt="" :src="profile.imagePath">
                            </div>
                            <div class="info">
                                <div class="title">
                                    <a target="_blank" href="">{{profile.name}}</a>
                                </div>
                                <div class="desc">{{profile.title}}</div>
                                <div class="desc" v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</div>
                            </div>
                            <div class="bottom">
                                <button type="button" class="btn btn-default" data-toggle="modal" :data-target="'#' + index">View Profile</button>
                            </div>
                        </div>
                        <div :id="index" class="modal fade" role="dialog">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <div class="col-md-12">
                                            <div class="info">
                                                <h1>{{profile.name}}</h1>
                                                <h4>{{profile.title}}</h4>
                                                <h4 v-if="profile.specialJobDesignation">{{profile.specialJobDesignation}}</h4>
                                            </div>
                                            <div id="aboutMe">
                                                <div class="text-center">
                                                    <hr class="botm-line" />
                                                </div>
                                                <h4>About {{profile.name}}</h4>
                                                <div v-html="profile.bio"></div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
    export default {
        name: 'staff',
        data(){
            return {
                profiles: []
            }
        },
        created(){
            this.$http.get("StaffProfiles")
                .then(response => {
                    this.profiles = response.data;
                });
        }
    }
</script>